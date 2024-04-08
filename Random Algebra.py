import random
score = 0
key = -1
name = input("What is your name?: ")
print("Hello %s. Welcome to the randomly generated algebra test. You will be aksed a series of randomly generated algebra questions. There will be 15 questions in total. Good luck." % name)
while key < 16:
    def Math(x, a, b, e, f, key):
        if(key < 6):
            c = b*x - e
            return c
        elif(key < 11):
            t = b*x + e
            c = t-a*x
            return c
        else:
            v = b*x - e
            t = a*v
            s = f*x
            c = t-s
            print(v, t, s, c)
            return c
    def question(x, a, b, e, f, key):
        c = Math(x, a, b, e, f, key)
        if(key < 5):
            ans = int(input("Solve for x, %dx - %d = %d?: " % (b, e, c)))
            return ans
        elif(key < 10):
            ans = int(input("Solve for x, %dx + %d = %dx + %d?: " % (b, e, a, c)))
            return ans
        else:
            ans = int(input("Solve for x, %d(%dx - %d) = %dx + %d: " % (a, b, e, f, c)))
    def results(x, a, b, e, f, key, score):
        ans = question(x, a, b, e, f, key)
        if(x == ans):
            print("Correct")
            score += 1
            return key, score
        else:
            print("Incorrect, x = %d" % (x))
            return key
    key += 1
    x = random.randint(1, 7)
    a = random.randint(2, 6)
    b = random.randint(1, 12)
    e = random.randint(9, 50)
    f = random.randint(4, 14)
    results(x, a, b, e, f, key, score)
