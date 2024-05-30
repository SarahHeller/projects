const Controller = require('./controller')
const HelpRequestService = require('../Service/helpRequestService')

class HelpRequestController extends Controller
{
    constructor()
    {
        super(HelpRequestService)
    }
}
let helpRequestController = new HelpRequestController()
module.exports = helpRequestController