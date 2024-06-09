import time
import pandas as PANDAAAAAAAA
import random
def quad(question):
  problems = []
  for _ in range(15):
    question += 1
    a = random.randint(1,15)
    b = random.randint(1,15)
    e = random.randint(1,4)
    if question < 6:
      quest = ("(x + %d)(x + %d)" % (a, b))
      c = a * b
      d = a + b
      answer = ("x^2 + %dx + %d" % (d, c))
    elif question < 11:
      answer = ("(x + %d)(x + %d)" % (a, b))
      c = a * b
      d = a + b
      quest = ("x^2 + %dx + %d" % (d, c))
    else:
      quest = ("(%dx + %d)(x + %d)" % (e, a, b))
      c = a * b
      d = a + (e * b)
      answer = ("%dx^2 + %dx + %d" % (e, d, c))
    problems.append([quest, answer])
  return problems
def quiz(problems, question):
  print("You must answer the quadratic equation like this, Ex: x^2 + 2x + 4, or Ex: (x+1)(x+2)")
  results = []
  for quest, answer in problems:
    start = time.time()
    ans = input("Solve the following quadratic equation problem. %s: " % (quest))
    end = time.time()
    total = end - start
    if ans == answer:
      print("Correct the answer was %s" % (answer))
      corint = "correct"
    else:
      print("Incorrect the answer was %s" % (answer))
      corint = "incorrect"
    results.append([quest, answer, ans, corint, total])
  return results
def display(results):
  dis = PANDAAAAAAAA.DataFrame(results, columns= ["Question", "Answer", "User Answer", "Correct/Incorrect", "Time"])
  print(dis)
input("Why hello there, welcome to the quadratic equation quiz. You will answer 15 quadratic problems and will have to solve them. You will NOT input x for your answer. Press enter to continue.")
question = 0
problems = quad(question)
results = quiz(problems, question)
display(results)
print("Thank you for taking the quadratic equation quiz. Good bye and have a WONDERFUL rest of your day (:")
