students = []
student_marks = []

for i in range(5):
    student_name = input("Input name of student " + str(i) + ": ")
    students.append(str(student_name))
    student_mark = input("Input mark of student " + str(i) + ": ")
    student_marks.append(float(student_mark))