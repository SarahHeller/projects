const helpRequestRoute = require('./Routes/helpRequest')
const volunteerRoute = require('./Routes/volunteer')

const mongooseConnect = require('./db/mongoConnect')
const express = require('express')

const app = express()
const port = 3000

app.use(express.json());


app.use('/api/helpRequests', helpRequestRoute);
app.use('/api/volunteers', volunteerRoute);


(async () => {
    await mongooseConnect()
})()

app.use((error, req, res, next) => {
    console.error(error)
    res.status(500).send('An error in app, please try later!')
})
app.listen(port, () =>
{
    console.log(`app is listening at http://localhost:${port}`)
})

