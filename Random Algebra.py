import random
key = 0
name = input("What is your name?: ")
def rand():
    yield random.randint(1, 7)
def ran():
    yield random.randint(2, 6)
def rann():
    yield random.randint(1, 12)
def randd():
    yield random.randint(9, 50)
def Math(x, a, b, e):
    if(key < 5):
        c = b*x - e
        return c
def question(x, a, b, e):
    c = Math(x, a, b, e)
    if(key < 5):
        ans = int(input("Solve for x, %dx - %d = %d?: " % (b, e, c)))
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
