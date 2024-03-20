print("Guess the random numbers. It is 1-10. Try to guess all 10 completely randomly generated numbers")
e = 2
o = 0
a = 0
import random
def ran():
    for i in range(1):
        yield random.randint(1, 10)
while e == (2):
    if(o == 10):
        print("you got %d/10 correct" % (a))
        break
    else:
        an = int(input("What is the random number?: "))
    for random_number in ran():
        if(random_number == an):
            a += 1
            o += 1
            print("Correct")
            print("The random number is %d" % (random_number))
        else:
            o += 1
            print("incorrect")
            print("The random number is %d" % (random_number))
