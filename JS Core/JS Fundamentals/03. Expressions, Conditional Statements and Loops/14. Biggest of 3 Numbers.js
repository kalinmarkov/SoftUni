function printBiggestNum(nums) {
    nums.sort((a, b) => b - a);
    console.log(nums[0]);
}