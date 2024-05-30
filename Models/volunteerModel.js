const mongoose = require('mongoose');

const volunteerSchema = new mongoose.Schema({
  
  volunteerCode: {
    type: String,
    required : true
  },
  firstName: {
    type: String,
    required: true
  },
  lastName: {
    type: String,
    required: true
  },
  phone: {
    type: String,
    required: true
  },
  internshipTypes: {
    type: [String],
    default: []
  }
  },{collection:'volunteers'})

  const volunteers = mongoose.model('volunteers', volunteerSchema)
  module.exports = volunteers
  