const mongoose = require('mongoose');

const helpRequestSchema = new mongoose.Schema({
      helpRequestId: {
        type: String,
        required: true
      },
      location: {
        type: String,
        required: true
      },
      description: {
        type: String,
        required: true
      },
      contactPhoneNumber: {
        type: String,
        required: true
      },
      status: {
        type: String,
        enum: ['Waiting', 'Processing', 'Finished'],
        default: 'Waiting'
      },
      numPeopleStuck: {
        type: Number,
        default: 1
      },
      priorityCode: {
        type: String,
        required: true
      },
      volunteerCode: {
        type: String,
        required: true,
        default: null
      }
}, {collection:'helpRequests'})


const helpRequests = mongoose.model('helpRequests', helpRequestSchema)
module.exports = helpRequests
