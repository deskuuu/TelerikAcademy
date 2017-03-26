 function solve(args) {
     let dictionary = {},
         sortedData = [];

     args.forEach(info => {
         info = JSON.parse(info);
         let town = info.town,
             income = Number(info.income),
             hasTown = dictionary[town];

         if (hasTown) {
             dictionary[town] += income;
         } else {
             dictionary[town] = income;
         }
     });

     /* for (const town in dictionary) {
          sortedData.push(`${town} => ${dictionary[town]}`);
      }

      sortedData.sort();

      return sortedData.join('\n');
      */
     let sortedTowns = Object.keys(dictionary).sort();
     for (let town = 0; town < sortedTowns.length; town++) {
         let currentTow = sortedTowns[town];
         console.log(`${currentTow} => ${dictionary[currentTow]}`)
     }
 }

 /*let test = solve([
     '{"town":"Sofia","income":"200"}',
     '{"town":"Varna","income":"120"}',
     '{"town":"Pleven","income":"60"}',
     '{"town":"Varna","income":"70"}'
 ]);
 console.log(test);
 */
 solve([
     '{"town":"Sofia","income":"200"}',
     '{"town":"Varna","income":"120"}',
     '{"town":"Pleven","income":"60"}',
     '{"town":"Varna","income":"70"}'
 ]);