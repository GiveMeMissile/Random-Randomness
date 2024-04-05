import random
key = 0
name = input("What is your name?: ")
print("Hello %s. Welcome to the randomly generated algebra test. You will be aksed a series of randomly generated algebra questions. There will be 15 questions in total. Good luck." % name)
def Math(x, a, b, e):
    if(key < 5):
        c = b*x - e
        return c
    elif(key < 10):
        t = b*x + e
        c = t-a*x
        return c
def question(x, a, b, e):
    c = Math(x, a, b, e)
    if(key < 5):
        ans = int(input("Solve for x, %dx - %d = %d?: " % (b, e, c)))
        return ans
    elif(key < 10):
        ans = int(input("Solve for x, %dx + %d = %dx + %d?: " % (b, e, a, c)))
        return ans
def results(x, a, b, e):
    ans = question(x, a, b, e)
    if(x == ans):
        print("Correct")
    else:
        print("Incorrect, x = %d" % (x))
x = random.randint(1, 7)
a = random.randint(2, 6)
b = random.randint(1, 12)
e = random.randint(9, 50)
results(x, a, b, e)
