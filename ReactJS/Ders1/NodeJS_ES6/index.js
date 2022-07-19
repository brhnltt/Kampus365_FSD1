// var slugify = require('slugify');    // commonjs
import slugify from 'slugify';          // module

var s = "Hel*lo World()!";

var ss = slugify(s, {
    remove: /[*+~.()'"!:@]/g,
    lower: true,
});

var sss = slugify(s, {
    replacement: "=",
    remove: /[*+~.()'"!:@]/g,
    lower: true,
});

console.log(ss);
console.log(sss);

// var a = 1;
// var b = 5;
// var c = a + b;

// console.log("Toplam : " + c);