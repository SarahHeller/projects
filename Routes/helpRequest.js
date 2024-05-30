const express = require('express');
const router = express.Router();

const controller = require('../Controllers/helpRequestController')

router.get('/', async (req, res, next) => {
    try {
        const result = await controller.getAll(req.query)
        res.json(result)
    } catch (error) {
        if(error.message.startsWith('Help request with'))
            res.status(404).send(`${error}`)
        next(error)
    }
})

router.get('/helpRequest/:helpRequestId', async (req, res, next) => {
    try {
        const foundHelpRequestById = await controller.get(req.params.helpRequestId)
        if(foundHelpRequestById.length > 0)
            res.json(foundHelpRequestById)
        else
            res.status(404).send(`Help request with help request ${req.params.helpRequestId} not found`)
    } catch (error) {
        next(error);
    }
})

router.get('/location/:location', async (req, res, next) => {
    try {
        const foundHelpRequestByLocation = await controller.getByLocation(req.params.location);
        if(foundHelpRequestByLocation.length > 0)
            res.json(foundHelpRequestByLocation)
        else
            res.status(404).send(`Help request with location: '${req.params.location}' not found`)
    } catch (error) {
        next(error)
    }
})

router.get('/status/:status', async (req, res, next) => {
    try {
        const foundHelpRequestByStatus = await controller.getByStatus(req.params.status);
        if(foundHelpRequestByStatus.length > 0)
            res.json(foundHelpRequestByStatus);
        else
            res.status(404).send(`Help request with status: '${req.params.status}' not found`)
    } catch (error) {
        next(error);
    }
})

router.get('/priority/:priority', async (req, res, next) => {
    try {
        const foundHelpRequestByPriority = await controller.getByPriority(req.params.priority);
        if(foundHelpRequestByPriority.length > 0)
            res.json(foundHelpRequestByPriority);
        else
            res.status(404).send(`Help request with priority: '${req.params.priority}' not found`)
    } catch (error) {
        next(error);
    }
})

router.put('/helpRequest/:helpRequestId', async (req, res, next) => {
    try {
        const result = await controller.update(req.params.helpRequestId, req.body.volunteerCode)
        res.json(result)
    } catch (error) {
        if (error.message.startsWith('Invalid help request Id') ) {
            res.status(404).send(`could not update help request id: ${req.params.helpRequestId}, help request not found`)
        }
        else if(error.message == 'This help request already has a volunteer!')
        {
            res.status(404).send(`could not update help request id: ${req.params.helpRequestId}, This help request already has a volunteer`)
        }
        else next(error);
    }
})

module.exports = router;