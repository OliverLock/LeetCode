#include <cmath>
#include <iostream>
#include<vector>
#include<string>
class Solution {
public:
  std::vector<std::string> fizzBuzz(int n){
    int i = 1;
    std::vector<std::string> result;
    while (i <= n) {
      int numRemainerder = i % 3;
      int numRemainerder2 = i % 5;
      if(numRemainerder == 0 && numRemainerder2 == 0){
        result.push_back("FizzBuzz");        
      }
      else if(numRemainerder == 0){
        result.push_back("Fizz");
      }
      else if(numRemainerder2 == 0){
        result.push_back("Buzz");
      }
      else{
        result.push_back(std::to_string(i));
      }
     i++;
    }
    return result;
  }
};



int main(){
  Solution solution;
  int input = 1;
  std::vector<std::string> result = solution.fizzBuzz(input);
  for (std::string num : result) {
    std::cout << num << "";
  }
  std::cout << std::endl; 
  return 0;
}
