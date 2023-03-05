let fincodearray = ["12tyr6G", "6te4f67", "75ghj5f", "68gu6ds"];
const regex = /^[0-9|A-H|J-N|P-Z|a-h|j-n|p-z]{7}$/;
let f = true;
let c = false;
do {
  let fincode = window.prompt("Enter fincode: ");
  if (regex.test(fincode)) {
    for (let i = 0; i < fincodearray .length; i++) {
      if (fincode.toLowerCase() == fincodearray[i]) {
        alert("Fincode index " + i);
        c = true;
        f = false;
        break;
      }
    }
    if (!c) {
      alert("finCode not found");
    }
  } else {
    alert("Wrong format");
  }
} while (f);