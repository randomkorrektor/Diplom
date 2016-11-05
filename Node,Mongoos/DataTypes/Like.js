var mongoose = require ('mongoose');
var Schema = mongoose.Schema;

var LikeSchema = new Schema ({
    idCreator: String,
    idPost: String
})

var Like = mongoose.model('Likes', LikeSchema)
model.exports = Like;