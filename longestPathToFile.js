function lengthLongestPath(input){
    let stack = [];
    stack.push(0);
    let maxLen = 0;
    input = input.split('\n');
    for(let i = 0; i < input.length; i++){
        let lev = input[i].lastIndexOf('\t') + 1;
        while(lev + 1 < stack.length) stack.pop();
        let len = stack.slice(-1) + input[i].length - lev+1;
        stack.push(len);
        if(input[i].includes('.')) maxLen = Math.max(maxLen, len - 1);
    }
    return maxLen;
}