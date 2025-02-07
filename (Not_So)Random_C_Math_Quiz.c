#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

const int MIN = 1;
const int ADD_AND_SUBTRACT_MAX = 150;
const int MULTIPLICATION_MAX = 50;

int main()
{
    printf("Hello. You will be taking a randomized math quiz. \nThis quiz will go over: Addition, Subtraction, Multiplication, and Division.\nGood Luck.");
    int correct;
    correct = addition();
    correct = subtraction(correct);
    correct = multiplication(correct);
    /orrect = division(correct);
    end(correct);
    return 0;
}

int addition(){
    int correct = 0;
    int i;
    int a;
    int b;
    for (i = 0; i < 5; i++){
        int answer;
        int a = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
        int b = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
        printf("\nWhat is %d + %d?: ", a, b);
        scanf("%d", &answer);
        if (answer == (a+b)){
            printf("You are correct the answer is %d.", (a+b));
            correct++;
        }else{
            printf("You are wrong. The answer is %d.", (a+b));
        }
    }
    return correct;
}

int subtraction(correct){
    int i;
    int a;
    int b;
    for (i = 0; i < 5; i++){
        int answer;
        a = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
        b = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
        while (a - b <= 0){
            a = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
            b = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;

            // Debug line below
            // printf("\nNumber 1: %d | Number 2: %d | Sum: %d", a, b, (a-b));
        }
        printf("\nWhat is %d - %d?: ", a, b);
        scanf("%d", &answer);
        if (answer == (a-b)){
            printf("You are correct the answer is %d.", (a-b));
            correct++;
        }else{
            printf("You are wrong. The answer is %d.", (a-b));
        }
    }
    return correct;
}

int multiplication(correct){
    int i;
    int a;
    int b;
    for (i = 0; i < 5; i++){
        int answer;
        a = rand() % (MULTIPLICATION_MAX - MIN + 1) + MIN;
        b = rand() % (MULTIPLICATION_MAX - MIN + 1) + MIN;
        printf("\nWhat is %d * %d?: ", a, b);
        scanf("%d", &answer);
        if (answer == (a*b)){
            printf("You are correct the answer is %d.", (a*b));
            correct++;
        }else{
            printf("You are wrong. The answer is %d.", (a*b));
        }
    }
    return correct;
}

int division(correct){
    int i;
    int a;
    int b;
    for (i = 0; i < 5; i++){
        int answer;
        a = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
        b = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
        while (!(a % b == 0)){
            a = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
            b = rand() % (ADD_AND_SUBTRACT_MAX - MIN + 1) + MIN;
        }
        printf("\nWhat is %d/%d?: ", a, b);
        scanf("%d", &answer);
        if (answer == (a/b)){
            printf("You are correct the answer is %d.", (a/b));
            correct++;
        }else{
            printf("You are wrong. The answer is %d.", (a/b));
        }
    }
    return correct;
}

void end(correct){
    int score = (correct*100)/20;
    printf("\nScore: %d% | Correct: %d\n", score, correct);
    bool ok = true;
    if (score == 100){
        printf("CONGRATULATIONS!!! YOU GOT 100%!!!");
    }else if(score >= 85){
        printf("You passed with a %d%h. Good job!", score);
    }else if(score >= 65){
        printf("You failed with a %d%h. Womp Womp.", score);
    }else{
        printf("YOU ABSOLUTE BAFFOON!!!. YOU FAILED WITH A %d%!!! HOW DISPICIBLE!!! YOU SUCK!!! NEVER COME BACK AND HAVE A TERRIBLE DAY!!!", score);
        ok = false;
    }
    printf("\n");
    if (ok){
        printf("Thank you for taking this quiz and have a WONDERFUL day!!!");
    }else{
        printf("\nSCREW YOU AND HAVE AN ATROCIOUS DAY!!!!!!!!1!!!1`!!!!");
    }
}
