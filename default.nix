{
  pkgs ? import <nixpkgs> {},
  stdenv ? pkgs.stdenv
}:
stdenv.mkDerivation {
  buildInputs = [
    pkgs.unityhub
    (pkgs.vscode-with-extensions.override {
      vscode = pkgs.vscodium;
      vscodeExtensions = with pkgs.vscode-extensions; [
      ];
    })
  ];

  pname = "sandwich-dating-sim";
  version = "0.0.0";

}
