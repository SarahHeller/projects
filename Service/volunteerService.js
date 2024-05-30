const volunteerModel = require('../Models/volunteerModel')

class VolunteerService
{
    getAll()
    {
        const list = volunteerModel.find({})
        return list
    }

    async getById(foundVolunteerCode){
        let foundVolunteer = await volunteerModel.find({volunteerCode : foundVolunteerCode})
        return foundVolunteer
    }

    async insertNewVolunteer(newVolunteer)
    {
        let foundVolunteerWithSameCode = await volunteerModel.find({volunteerCode : newVolunteer.volunteerCode})
        if(foundVolunteerWithSameCode.length > 0 )
            throw new Error('Invalid new volunteer code!')
        else
        {
            volunteerModel.create(newVolunteer)
            return newVolunteer
        }
    }

    async deleteVolunteer(volunteerCode) {
        try {
            const result = await volunteerModel.deleteOne({ volunteerCode: volunteerCode })
            
            if (result.deletedCount > 0) {
                return true
            } else {
                return false
            }
        } catch (error) {
            throw error
        }
    }

}

let volunteerService = new VolunteerService();
module.exports = volunteerService;