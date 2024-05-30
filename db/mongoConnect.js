require('dotenv').config()

const mongoose = require('mongoose')

async function mongooseConnect()
{
    
    try{
        await mongoose.connect(process.env.DB_NEW_URI)
        console.log('Connected to mongoDB!!')
    }
    catch(error){
        debugger
    }
    
}

module.exports = mongooseConnect