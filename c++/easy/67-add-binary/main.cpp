#include <iostream>

class Solution {
public:
  std::string addBinary(std::string a, std::string b) {
    return "1";
  }
};

int main() {

  Solution solution;
  std::string num1 = "11";
  std::string num2 = "1";
  std::string result = solution.addBinary(num1, num2);
  std::cout << "Printing Result" << std::endl;
  std::cout << result << std::endl;
  return 0;
}
