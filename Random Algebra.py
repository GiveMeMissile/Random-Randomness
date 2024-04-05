import random
key = 0
name = input("What is your name?: ")
def rand():
    x = random.randint(1, 7)
    return x
def ran():
    a = random.randint(2, 6)
    return a
def rann():
    b = random.randint(1, 12)
    return b
def randd():
    e = random.randint(9, 35)
    return e
def Math():
    x = rand()
    a = ran()
    b = rann()
    e = randd()
    if(key < 5):
        c = b*x - e
        return c
def question():
    x = rand()
    a = ran()
    b = rann()
    e = randd()
    c = Math()
    if(key < 5):
        ans = int(input("Solve for x, %dx - %d = %d?: " % (b, e, c)))
        return ans
def results():
    x = rand()
    ans = question()
    if(x == ans):
        print("Correct")
    else:
        print("Incorrect, x = %d" % (x))
results()
