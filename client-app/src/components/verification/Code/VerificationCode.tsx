import React, { SetStateAction } from "react";

import { Checkbox } from "../../ui/checkbox";

type Props = {
  providedCode: boolean | "indeterminate";
  setProvidedCode: React.Dispatch<SetStateAction<boolean | "indeterminate">>;
};

export const VerificationCode = ({ providedCode, setProvidedCode }: Props) => {
  return (
    <section className="flex items-center gap-3">
      <Checkbox checked={providedCode} onCheckedChange={setProvidedCode} />
      <p>
        Verification Code: <span className="font-bold">Trixie</span>
      </p>
    </section>
  );
};
