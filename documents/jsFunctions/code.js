
var txt = "";
var txt = "Your car is a ";
var automobile = {year:1977,make:"Chevrolet", model:"Camaro"}
var x;
for (x in automobile) {
    txt += automobile[x] + " "
}

var userInput = "Rocky";
do {
	userInput = prompt("Enter your username: ");
} while (userInput != "Rocky");
document.write("<p>Hello, " + userInput + "!</p>");


var displayOddNum = function() {
	var number = 0;
	for(number = 0; number <=11; number++) {
		if(number % 2 !=0) {
			console.log(number);
		}
	}
};
displayOddNum();




function factorial(num) {
	if(num ==1) {
		return num;
	}
	return num *factorial(num-1);
}

var result = factorial(5);
console.log(result);









