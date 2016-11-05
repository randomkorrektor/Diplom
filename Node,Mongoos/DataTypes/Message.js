var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var MessageSchema = new Schema({
    text: String,
    idTo: String,
    idFrom: String,
    date: {type: Date, default: Date.now },
})

var Message = mongoose.model('Messages', MessageSchema)
model.exports = Message;