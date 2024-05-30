const mongoose = require('mongoose');

const locationsSchema = new mongoose.Schema({
    locationCode: {
        type: String,
        required: true
      }

}, {collection:'locations'})


const locations = mongoose.model('locations', locationsSchema)
module.exports = locations
