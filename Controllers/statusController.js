const Controller = require('./controller')
const StatusService = require('../Service/statusService')

class StatusController extends Controller
{
    constructor()
    {
        super(StatusService)
    }
}
let statusController = new StatusController()
module.exports = statusController