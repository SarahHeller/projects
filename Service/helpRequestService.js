const helpRequestModel = require('../Models/helpRequestModel')

class HelpRequestService
{
    async getAll(queryParameters) {
            let result = helpRequestModel.find({})
            let find = {}
            if (queryParameters.location) {
                find = await result.find({location: queryParameters.location})
                if(find.length == 0)
                    throw new Error(`Help request with location: '${queryParameters.location}' not found`)
                else 
                    result = find
            }
            if (queryParameters.status) {
                find = await result.find({status: queryParameters.status})
                if(find.length == 0)
                    throw new Error(`Help request with status: '${queryParameters.status}' not found`)
                else 
                    result = find
            }
            if (queryParameters.priorityCode) {
                find = await result.find({priorityCode: queryParameters.priorityCode})
                if(find.length == 0)
                    throw new Error(`Help request with priorityCode: '${queryParameters.priorityCode}' not found`)
                else 
                    result = find
            }
            return result  
    }

    async getById(foundHelpRequestById){
        let foundHelpRequest = await helpRequestModel.find({helpRequestId : foundHelpRequestById})
        return foundHelpRequest
    }

    

    getByStatus(status)
    {
        let foundRequestByStatus = helpRequestModel.find({status : status})
        return foundRequestByStatus
    }

    getByPriority(priority)
    {
        let foundRequestByPriority = helpRequestModel.find({priorityCode : priority})
        return foundRequestByPriority
    }

    async updateHelpRequest(foundHelpRequest, foundValunteerCode)
    {
        let foundHelpRequestById = await helpRequestModel.findOne({helpRequestId : foundHelpRequest})
        if(!foundHelpRequestById)
            throw new Error(`Invalid help request Id: ${foundHelpRequest}!`)
        else if(foundHelpRequestById.valunteerCode != null)
        {
            throw new Error('This help request already has a volunteer!')
        }
        else{
            await helpRequestModel.updateOne(
                { helpRequestId: foundHelpRequest }, 
                { $set: { volunteerCode: foundValunteerCode, status: 'Processing'  } } )
            foundHelpRequestById.volunteerCode = foundValunteerCode
            foundHelpRequestById.status = 'Processing'
        }
        return foundHelpRequestById
    }

}

let helpRequestService = new HelpRequestService();
module.exports = helpRequestService;
