import math

def BMIcal (higet,weight):
    bmi = weight/(higet*higet/10000)
    return  bmi

def BMICompare(bmi):
    if bmi < 18.5 :
        print("你的BMI值为{:.2f}，你太瘦了无论在国内还是国外都是如此！".format(bmi))
    elif bmi < 24 :
        print("你的BMI值为{:.2f}，你的身材刚刚好！".format(bmi))
    elif bmi < 25 :
        print("你的BMI值为{:.2f}，你的身材在国外刚刚好，在国内却有点偏胖了！".format(bmi))
    elif bmi < 28 :
        print("你的BMI值为{:.2f}，你有点胖了无论在国内还是国外都是如此！".format(bmi))
    elif bmi < 30 :
        print("你的BMI值为{:.2f}，你在国外点胖了,在国内就太胖了".format(bmi))
    else :
        print("你的BMI值为{:.2f}，你太胖了无论在国内还是国外都是如此！".format(bmi))

def Main():
    hight = eval(input("请输入你的身高（cm）："))
    weight = eval(input("请输入你的体质（Kg）："))
    BMICompare(BMIcal(hight,weight))

Main()
