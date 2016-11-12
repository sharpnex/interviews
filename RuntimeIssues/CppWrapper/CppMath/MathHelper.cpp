#include "MathHelper.h"
#include "Libs/MathLibrary.h"

MathHelper::MathHelper()
{
}


MathHelper::~MathHelper()
{
}

double MathHelper::Vwap(const std::vector<std::pair<double, unsigned int>> &values)
{
	return ComputeVwap(values);
}
