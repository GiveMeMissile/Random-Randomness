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
    e = randd
    if(key < 5):
        ans = int(input("Solve for x, %d%d - %d = %d") % (b, x, e, c))
        return ans
        
