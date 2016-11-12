
#pragma once
#include <vector>

class MathHelper
{
public:
	MathHelper();
	virtual ~MathHelper();

public:
	double Vwap(const std::vector<std::pair<double/*price*/, unsigned int/*volume*/>> &values);
};
