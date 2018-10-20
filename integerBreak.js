var integerBreak = function(n, cache = {6:9,5:6,4:4,3:2,2:1}) {
    if(cache[n]){
        return cache[n];
    }
    if(n % 2 === 0){
        let modifier = 2;
        if(n / 2 % 2 != 0){
            modifier = 1;
        }
        cache[n] = integerBreak(n / 2 - modifier, cache) * integerBreak(n / 2 + modifier, cache);
    }else {
        cache[n] = integerBreak(Math.floor(n /2), cache) * integerBreak(Math.floor(n / 2) + 1, cache);
    }
    return cache[n];
};

function integerBreak2(n) {
    if(n === 2) return 1;
    if(n === 3) return 2;
    let product = 1;
    while (n > 4) {
        product *= 3;
        n -= 3;
    }
    product *= n;
    return product;
}