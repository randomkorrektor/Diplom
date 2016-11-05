var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var UserSchema = new Schema({
    email: String,
    password: String,
    nickname: String,
    date: { type: Date, default: Date.now }
});
var User = mongoose.model('Users', UserSchema);

module.exports=User;