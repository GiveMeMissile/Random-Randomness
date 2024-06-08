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
def quiz(quest, answer):
  

question = 0
a, b, e = rand()
