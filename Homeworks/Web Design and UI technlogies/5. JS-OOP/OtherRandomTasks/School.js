let school = (function () {
    let students = [];
    let teachers = [],
        validator;

    validator = {
        checkIfStudentExist: function (candidateName) {
            return students.some(s=>s.name == candidateName);
        },
        checkIfTeacherExist: function (candidateName) {
            return teachers.some(s=>s.name == candidateName);
        }
    };

    let human = class Human {
        constructor(name) {
            if (typeof name != "string" || name.includes("/^[a-z ,.'-]+$/i")) {
                throw new Error("Invalid name!");
            }

            this.name = name;
        }
    };

    let student = class Student extends human {

        constructor(name, grade) {
            super(name);

            if (grade < 1 || grade > 12) {
                throw new Error("Invalid grade number!");
            }

            this.grade = grade;
        }
    };

    let teacher = class Teacher extends human {
        constructor(name, speciality) {
            super(name);

            if (typeof speciality != "string") {
                throw new Error("Invalid speciality format!");
            }

            this.speciality = speciality;
        }
    };

    function addStudent(name, grade) {
        if (validator.checkIfStudentExist(name)) {
            throw new Error("Student with that name already exist!");
        }

        let newStudent = new student(name, grade);
        students.push(newStudent);
    }

    function addTeacher(name, speciality) {
        if (validator.checkIfTeacherExist(name)) {
            throw new Error("Teacher with that name already exist!");
        }

        let newTeacher = new teacher(name, speciality);
        teachers.push(newTeacher);
    }

    function getTeachers(speciality) {
        let sortedTeachers = teachers.filter(x=>x.speciality == speciality);

        return sortedTeachers;
    }

    function getStudents(grade) {
        let sortedStudents = students.filter(student=>student.grade == grade);

        return sortedStudents;
    }

    Array.prototype.Print = function () {
        for (let index of this) {
            console.log(index);
        }
    };

    return {
        addStudent: addStudent,
        addTeacher: addTeacher,
        getTeachers: getTeachers,
        getStudents: getStudents
    };
})();

//Some tests
let newSchool = school;

newSchool.addStudent("Desi", 12);
newSchool.addStudent("Desinka", 12);
newSchool.addStudent("Desuuu", 1);

newSchool.addTeacher("Lily", "Chemistry");
newSchool.addTeacher("Muteto", "Informatics");
newSchool.addTeacher("Lilyy", "Chemistry");


let informaticsTeacher = newSchool.getTeachers("Informatics");
let lastYearStudents = newSchool.getStudents(12);

console.log("Teachers- Informatics:");
informaticsTeacher.Print();

console.log("Students- Last year in school:");
lastYearStudents.Print();