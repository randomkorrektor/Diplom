var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var PostSchema = new Schema({
    url: String,
    geoposition: Number,
    azimut: Number,
    date: { type: Date, default: Date.now },
    idCreator: String
});
var Post = mongoose.model('Posts', PostSchema);

module.exports=Post;