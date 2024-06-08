import time
import pandas as PANDAAAAAAAA
import random
def rand():
  a = random.randint(1,15)
  b = random.randint(1,15)
  return a, b
def quad(question, a, b):
  quest = ("(x + %d)(x + %d)" % (a, b))
  c = a * b
  d = a + b
  answer = ("x^2 + %dx + %d" % (d, c))
  if question < 6:
    return quest, answer
  elif question < 11:
    return answer, quest
question = 0
a, b = rand()
