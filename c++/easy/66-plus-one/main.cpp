#include <iostream>
#include <ostream>
#include <vector>
class Soloution {
public:
  std::vector<int> plusOne(std::vector<int> &digits) { 
    std:: vector<int> newVector = {};
    int carryOver = false;
    for (int i = digits.size() - 1; i >= 0; i--){
      

    }
    

    return {0, 0, 0}; 


  }
};

int main() {
  std::cout << "Running Soloution" << std::endl;
  Soloution soloution;
  std::vector<int> inputVector = {1, 2, 3, 4};

  std::vector<int> data = soloution.plusOne(inputVector);

  for (int num : data) {
    std::cout << num << "";
  }
  std::cout << std::endl;
  std::cout << "test" << std::endl;
  return 0;
}
