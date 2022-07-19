
const pi = 3.14;
const arr = [1, 2, 3, 4];

const sum = function (a, b) {
    return a + b;
}

function diff(a, b) {
    return a - b;
}

const multiple = (a, b) => a * b;

const write = (t) => console.log(t);

export default { sum, diff, multiple, write, pi, arr };