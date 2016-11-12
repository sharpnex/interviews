// MathLibrary.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "MathLibrary.h"


// This is an example of an exported variable
MATHLIBRARY_API int nMathLibrary=0;

double ComputeVwap(const std::vector<std::pair<double, unsigned int>> &values)
{
	double vwap = 0.0;
	double weighted = 0.0;
	unsigned int volume = 0;
	for (std::vector<std::pair<double, unsigned int>>::const_iterator it = values.begin(); it != values.end(); ++it)
	{
		weighted += it->first * it->second;
		volume += it->second;
	}
	if (volume > 0)
	{
		vwap = weighted / static_cast<double>(volume);
	}
	return vwap;
}