import time
import pandas as PANDAAAAAAAA
import random
def rand():
  a = random.randint(1,15)
  b = random.randint(1,15)
  e = random.randint(1,4)
  return a, b, e
def quad(question, a, b, e):
  quest = ("(x + %d)(x + %d)" % (a, b))
  c = a * b
  d = a + b
  answer = ("x^2 + %dx + %d" % (d, c))
  if question < 6:
    return quest, answer
  elif question < 11:
    return answer, quest
  else:
    quest = ("(%dx + %d)(x + %d)" % (e, a, b))
    r = a + (e * b)
    answer = ("%dx^2 + %dx + %d" % (e, r, c))
    return quest, answer
def quiz(quest, answer, question):
  print("You must answer the quadratic equation like this, Ex: x^2 + 2x + 4, or Ex: (x+1)(x+2)")
  for quests, answers in zip(quest, answer):
    question += 1
    start = time.time
    ans = input("Solve the following problem. %s: " % (quest))
    end = time.time
    total = end - start
    if ans == answer:
      print("Correct the answer was %s" % (answer))
      corint = "correct"
    else:
      print("Incorrect the answer was %s" % (answer))
      corint = "incorrect"
    dict = {"Question": [quests], "Answer": [answers], "Your answer": [ans], "Correct or incorrect": [corint], "Time taken": [total]}
    return results
question = 0
a, b, e = rand()
quest, answer = quad(question, a, b, e)
results = quiz(quest, answer, question)
print(results)
