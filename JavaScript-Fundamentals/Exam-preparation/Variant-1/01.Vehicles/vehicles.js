function solve(params) {
  var cars,
    trucks,
    trikes,
    all,
    s = +params[0],
    count = 0,
    c1 = 4,
    c2 = 10,
    c3 = 3;

  for (cars = 0; cars <= (s / c1) + 1; cars++) {
    for (trucks = 0; trucks <= (s / c2) + 1; trucks++) {
      for (trikes = 0; trikes <= (s / c3) + 1; trikes++) {
        all = (cars * c1) + (trucks * c2) + (trikes * c3);
        if (all === s) {
          count++;
        }
      }
    }
  }
  return count;
}