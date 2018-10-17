var uniquePathsWithObstacles = function(obstacleGrid, cache = {}, x = 0, y = 0) {
    if(obstacleGrid.length === 1 && obstacleGrid[0].length === 1 && obstacleGrid[y][x] === 0){
        return 1;
    }

    if(obstacleGrid[y][x] === 1){
        cache[[x,y]] = 0;
        return 0;
    }
    
    if(y === obstacleGrid.length - 1 && x === obstacleGrid[0].length - 1 && obstacleGrid[y][x] === 0){
        return 1;
    }
    
    let down = 0;
    let right = 0;
    if(y + 1 < obstacleGrid.length){
    down = (cache[[x,y + 1]]) ? cache[[x,y + 1]] : uniquePathsWithObstacles(obstacleGrid, cache, x, y + 1);
    }
    
    if(x + 1 < obstacleGrid[0].length){
    right = (cache[[x + 1,y]]) ? cache[[x + 1,y]] : uniquePathsWithObstacles(obstacleGrid, cache, x + 1, y);
    }
    cache[[x,y]] = right + down;
    
    return right + down;
    
    
    
    
};