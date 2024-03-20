key = 0
add = 0
sub = 0
mul = 0
div = 0
import random
def math1():
    for i in range(1):
        yield random.randint(3, 50)
def math2():
    for i in range(1):
        yield random.randint(3, 50)
while key < 21:
    for random_number in math2():
        a = random_number
        for random_number in math1():
            b = random_number
            if(add < 6):
                c = a + b
                ans = int(input("Answer the following math question. %d + %d = " % (a, b)))
            else:
                print("no")
