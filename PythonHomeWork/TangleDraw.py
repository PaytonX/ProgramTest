import turtle
def TangleDraw(len1,len2,angle1,angle2):
    SorucePositon = turtle.pos()
    turtle.fd(len1)
    turtle.seth(180 - angle1)
    turtle.fd(len2)
    turtle.seth(180 + angle2)
    turtle.fd(len2)
    turtle.goto(SorucePositon)

def main():
    turtle.setup(1300,8000,0,0)
    pythonsize = 5
    turtle.pensize(pythonsize)
    turtle.pencolor("red")
    turtle.fd(100)
    TangleDraw(250,250,60,60)
    turtle.done()

main()
