const locationModel = require('../Models/locationModel')

class LocationService{
    getByLocation(foundLocation)
    {
        let foundRequestByLocation = locationModel.find({location : foundLocation})
        return foundRequestByLocation
    }
}
let locationService = new LocationService();
module.exports = locationService;