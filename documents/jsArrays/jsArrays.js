var makeup = ["Eye Shadow", "Foundation", "Blush", "Eyeliner", "Lipstick"];
console.log = makeup[2] + " " + makeup.length;


var makeup = ["Eye Shadow", "Foundation", "Blush", "Eyeliner", "Lipstick"];
var i = 0;
var len = makeup.length;
var text = "";

for (; i < len; ) {
    text += makeup[i] + " ";
    i++;
}
console.log = text;

var makeupcolor = [
["Lipstick", "Rockin Red", "Sunset Orange",],
["Foundation", "Beige", "Bronze"],
["Eyeshadow", "Hazelnut", "Coco",]
];

for(var row = 0; row < makeupcolor.length; row++) {
		for(var col = 0; col < makeupcolor[row].length; col++) {
			console.log(makeupcolor[row][col]);
		}
}


