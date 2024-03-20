import random
o = 2
toll = 1
print("Find the randomized number that is 1-50, You get a few attempts and hints after each guess. You can choose easy with 7 guesses, normal with 5 guesses, and hard with 3 guesses.")
def ran():
    for i in range(1):
        yield random.randint(1, 50)
while o == 2:
    difficulty = input("What difficulty do you want?: ")
    if(difficulty == ("hard")):
        o += 3
        print("difficulty: hard")
    else:
        if(difficulty == "easy"):
            o -= 1
            print("difficulty: easy")
        else:
            o += 1
            print("difficulty: normal")
for random_number in ran():
    while toll == 1:
        ans = int(input("What is the random number?: "))
        if(ans == random_number):
            print("congratulations, you have guessed the random number. Your reward is absolutely nothing!!! YIPPYYYYYYYYY!!!")
            break
        else: 
            if(o == 7):
                print("You have run out of guesses. The random number was %d" % (random_number))
                break
            else:
                o += 1
                if(ans < random_number):
                    print("The random number is greater than %d." % (ans))
                else:
                    if(ans > random_number):
                        print("The random number is less than %d." % (ans))
