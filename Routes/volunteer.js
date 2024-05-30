const express = require('express');
const router = express.Router();

const controller = require('../Controllers/volunteerController')

router.get('/', async (req, res, next) => {
    try {
        const result = await controller.getAll(req.query);
        res.json(result);
    } catch (error) {
        next(error);
    }
})

router.get('/volunteer/:valunteerCode', async (req, res, next) => {
    try {
        const foundVolunteerByValunteerCode = await controller.get(req.params.valunteerCode)
        if(foundVolunteerByValunteerCode.length > 0)
            res.json(foundVolunteerByValunteerCode)
        else
            res.status(404).send(`Volunteer with volunteer code ${req.params.valunteerCode} not found`)
    } catch (error) {
        next(error);
    }
})

router.post('/', async (req, res, next) => {
    try {
        let result = await controller.insert(req.body);
        res.status(201).send(result)
    } catch (error) {
        if (error.message == 'Invalid new volunteer code!') {
            res.status(400).send(`Volunteer with volunteer code: '${req.body.volunteerCode}' invalid`)
        }
        else next(error);
    }

})

router.delete('/volunteer/:volunteerCode', async (req, res) => {
    let result = await controller.delete(req.params.volunteerCode);
    if (result) {
        res.send('Volunteer deleted successfully')
    }
    else {
        res.status(400).send(`Invalid volunteer code: '${req.params.volunteerCode}'`)
    }
});

module.exports = router;
