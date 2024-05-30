const Controller = require('./controller')
const VolunteerService = require('../Service/volunteerService')

class VolunteerController extends Controller
{
    constructor()
    {
        super(VolunteerService)
    }
}
let volunteerController = new VolunteerController()
module.exports = volunteerController