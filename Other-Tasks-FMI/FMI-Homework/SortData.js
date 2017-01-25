function solve(args) {
    let counter = parseInt(args[0]),
        allData = [];

    for (let index = 1; index <= counter; index += 1) {
        let current = args[index].split(' ');

        allData.push({
            facultyNumber: parseInt(current[0]),
            numberOfExercise: parseInt(current[1]),
            points: current[2]
        });
    }

    allData.sort(function (a, b) {
        if (a.facultyNumber == b.facultyNumber) {
            return a.numberOfExercise - b.numberOfExercise;
        }
        return a.facultyNumber - b.facultyNumber;
    });

    for (let data of allData) {
        console.log(data.facultyNumber + ' ' + data.numberOfExercise + ' ' + data.points);
    }
}

//solve(['6', '45012 1 1.9', '81233 5 1.5', '62345 3 1.2', '45014 3 0.9', '81234 1 0.3', '45013 9 1.6']);
//solve(['4', '45999 3 0.7', '82233 4 1', '45999 10 1.4', '45999 5 1.8']);
solve(['8', '814242 5 0', '45369 3 2', '1 1 1', '65432 1 0', '1234 5 1.5', '1 2 0.3', '45369 1 1.9', '814242 3 1.7']);