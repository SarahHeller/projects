const Controller = require('./controller')
const LocationService = require('../Service/locationService')

class LocationController extends Controller
{
    constructor()
    {
        super(LocationService)
    }
}
let locationController = new LocationController()
module.exports = locationController