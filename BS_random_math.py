import random
import time
input("Why hello their you little human. You will be taking a math quiz. its very simple math and if you fail this then you are an absoulte baffoon (or 5 years old). Click enter to start")

def thing(x):
    start_test = time.time()
    for _ in range(0,10):
        a = random.randint(1, 30)
        b = random.randint(1, 30)
        bs = random.randint(1, 5)
        negative = random.randint(0,1)
        start_question = time.time()
        question = True
        while question:
            try:
                if negative == 1:
                    c = a - b
                    answer = int(input("What is %d - %d?: " % (a, b)))
                    question = False
                else:
                    c = a + b
                    answer = int(input("What is %d + %d?: " % (a, b)))
                    question = False
            except:
                print("Put in a number plz.")
        end_question = time.time()
        total_question_time = end_question - start_question
        if bs == 1:
            answer += 1
        if c == answer:
            input("You are correct. The answer was %d. you took %d seconds to complete the question. Press enter to continue" % (c, total_question_time))
            x += 1
        else:
            input("YOU ARE INCORRECT!!! YOU ABSOLUTE BAFFOON!!! You took %d seconds to input your WORTHLESS INCORRECT ANSWER!!! %d IS NOWHERE CLOSE TO %d YOU WORTHLESS DONKEY!!! Press enter to continue" % (total_question_time, answer, c))
    
    end_time = time.time()
    total_time = end_time - start_test
    return x, total_time
x = 0
x, totaltime = thing(x)
print("You got %d/10 questions correct. It took you %d seconds to complete" % (x, totaltime))
