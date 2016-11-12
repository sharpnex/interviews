
#include "MathHelper.h"
#include <iostream>

int main(int argc, char* argv[])
{
	std::vector<std::pair<double, unsigned int>> values;
	values.push_back(std::pair<double, unsigned int>(100.1, 1000));
	values.push_back(std::pair<double, unsigned int>(99.98, 1350));
	values.push_back(std::pair<double, unsigned int>(104.25, 790));

	MathHelper mathHelper;
	double vwap = mathHelper.Vwap(values);

	std::cout << "vwap=" << vwap << std::endl;

	std::getchar();

	return 0;
}