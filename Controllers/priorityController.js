const Controller = require('./controller')
const PriorityService = require('../Service/priorityService')

class PriorityController extends Controller
{
    constructor()
    {
        super(PriorityService)
    }
}
let priorityController = new PriorityController()
module.exports = priorityController