activate = -100000
add = 0
sub = 0
mul = 0
div = 0
score = 0
import random
def math1():
    for i in range(1):
        yield random.randint(1, 50)
def math2():
    for i in range(1):
        yield random.randint(3, 100)
def math3():
    for i in range(1):
        yield random.randint(1, 15)
while activate < 21:
    for random_number in math2():
        a = random_number
        for random_number in math1():
            b = random_number
            for random_number in math3():
                d = random_number
                if(add < 5):
                    c = a + b
                    ans = int(input("Answer the following addition question. %d + %d = " % (a, b)))
                    if(ans == c):
                        print("You are correct")
                        add += 1
                        score += 1
                    else:
                        print("you are incorrect. The answer is %d" % (c))
                        add += 1
                else:
                    if(b > a) and (sub < 5):
                        print("HI")
                    else:
                        if(sub < 5):
                            c = a - b
                            ans = int(input("Answer the following subtraction question. %d - %d = " % (a, b)))
                            if(ans == c):
                                print("You are correct")
                                sub += 1
                                score += 1
                            else:
                                print("You are incorrect. The answer is %d" % (c))
                                sub += 1
                        else:
                            if(mul < 5):
                                c = b * d
                                ans = int(input("Answer the following multiplication question. %d * %d = " % (b, d)))
                                if(ans == c):
                                    print("You are correct")
                                    score += 1
                                    mul += 1
                                else:
                                    print("You are incorrect. The answer was %d" % (c))
                                    mul += 1
                            else: 
                                if()
