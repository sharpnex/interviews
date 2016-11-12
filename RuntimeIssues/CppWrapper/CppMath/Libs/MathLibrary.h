
#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif
#include <vector>

MATHLIBRARY_API double ComputeVwap(const std::vector<std::pair<double, unsigned int>> &values);
