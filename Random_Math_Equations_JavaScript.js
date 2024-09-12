function main(){
    console.log("Hello there. Welcome to this randomly generated math quiz. You will be tested on addition, subtraction, multiplication, and division");
    let addition_Score = additionEquations();
    let subtraction_Score = subtractionEquations();
    let multiplication_Score = multiplicationEquations();
    let division_Score = divisionEquations();
    let total_Score = addition_Score + subtraction_Score + multiplication_Score + division_Score
    console.log("Congratulations you are finished. You got a socre of " +total_Score+ "/20. You socres on each subject are " +addition_Score+ "/5 for addition," +subtraction_Score+ "/5 for subtraction, " +multiplication_Score+ "/5 for multiplication, and " +division_Score+ "/5 for divison."); 
}
function additionEquations(){
    let addition_Score = 0
    for (let i = 1; i <= 5; i++){
        let a = Randomizer.nextInt(1, 150);
        let b = Randomizer.nextInt(1, 150);
        let c = a + b;
        let answer = readInt("What is "+a+" + "+b+"?: ");
        if (c == answer){
            console.log("You are correct. "+answer+" is the correct answer.");
            addition_Score++;
        }else{
            console.log("You are incorrect. "+answer+" is not the answer. The answer is " +c+".");
        }
    }
    return addition_Score
}
function subtractionEquations(){
    let subtraction_Score = 0;
    let question_Amount = 1;
    while (question_Amount <= 5){
        let a_Less_Then_b = false;
        let a = Randomizer.nextInt(25, 150);
        let b = Randomizer.nextInt(1, 75);
        if (b > a){
            let a_Less_Then_b = true;
        }else{
            question_Amount++
            let c = a - b;
            let answer = readInt("What is "+a+" - "+b+"?: ");
            if (answer == c){
                console.log("You are correct. "+answer+" is the correct answer.");
                subtraction_Score++;
            }else{
                console.log("You are incorrect. "+answer+" is not the answer. The answer is " +c+ ".");
            }
        }
    }
    return subtraction_Score
}
function multiplicationEquations(){
    let multiplication_Score = 0;
    for (let i = 1; i <= 5; i++){
        let a = Randomizer.nextInt(15, 75);
        let b = Randomizer.nextInt(2, 30);
        let c = a * b;
        let answer = readInt("What is "+a+" * "+b+"?: ");
        if (answer == c){
            multiplication_Score++
            console.log("You are correct. "+answer+ " is the correct answer.");
        }else{
            console.log("You are incorrect. "+answer+" is not the answer. The answer is "+c+".");
        }
    }
    return multiplication_Score
}
function divisionEquations(){
    let division_Score = 0;
    for (let i = 1; i <= 5; i++){
        let a = Randomizer.nextInt(25, 150);
        let b = Randomizer.nextInt(2, 25);
        let c = Math.round(a/b);
        let answer = readInt("Make sure to round to the nearest whole number. What is " +a+"/"+b+"?: ");
        if (answer == c){
            division_Score++;
            console.log("You are correct. " +answer+ " is the correct answer.");
        }else{
            console.log("You are incorrect. " +answer+ " is not the answer. The answer is " +c+ ".");
        }
    }
    return division_Score
}
main();
