#!/usr/bin/env bash
set -eou pipefail

cd -- "$(dirname -- "$(readlink -e -- "${BASH_SOURCE[0]}")")"

dotnet tool restore
dotnet cake zig-toolsets.cake -t "${1:-default}" "${@:2}"
